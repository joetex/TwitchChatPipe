using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using VirtualBox;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TwitchChatPipe
{
    public class ButtonMaster
    {
        public Queue commandList = new Queue();
        public Queue prevCommandList = new Queue();
        public Form1 parent;
        public Dictionary<string,int> buttonHistory = new Dictionary<string,int>();
        public Dictionary<string,int> localButtonHistory = new Dictionary<string,int>();

        Type keytype = typeof(SNESKeys);

        //A custom key input for FF7 on steam
        public enum FF7Keys
        {
            up = Keys.Up,
            down = Keys.Down,
            left = Keys.Left,
            right = Keys.Right,
            l1 = Keys.PageUp,
            r1 = Keys.PageDown,
            t = Keys.V,
            o = Keys.X,
            x = Keys.C,
            s = Keys.Insert
        }

        //Setup these keys to match your emulator input binds
        public enum SNESKeys
        {
            up = Keys.W,
            down = Keys.S,
            left = Keys.A,
            right = Keys.D,
            l = Keys.B,
            r = Keys.N,
            a = Keys.Z,
            b = Keys.X,
            x = Keys.C,
            y = Keys.V,
            start = Keys.J,
            select = Keys.K
        }


        
        public ButtonMaster(Form1 p, Type kt)
        {
            parent = p;
            keytype = kt;
        }

        public void VerifyKeys(VBoxKeyboardHelper keyboard, string user, string keycode)
        {

            string[] sneskeys = Enum.GetNames(keytype);

            int total = 0;

            foreach( string k in sneskeys )
            {
                if (Regex.IsMatch(keycode, "^[ \t]*" + k + "[^a-zA-Z]*$", RegexOptions.IgnoreCase))
                {
                    
                    if (buttonHistory.ContainsKey(k)) {
                        buttonHistory[k]++;
                        localButtonHistory[k]++;
                    }
                    else {
                        buttonHistory[k] = 1;
                        localButtonHistory[k] = 1;
                    }

                    keycode = k;
                    total++;
                    break;
                }
            }


            if (total == 0)
                return;

            Keys code = ConvertKeyPress(keycode.ToLower());
            keyboard.SendKeyCode(code, true);
            parent.CommandLog(user+": "+keycode);
            prevCommandList.Enqueue(keycode);
          
        }

        public Keys ConvertKeyPress(string keycode)
        {
            return (Keys)Enum.Parse(keytype, keycode);
        }

        public void Update(VBoxKeyboardHelper keyboard)
        {
           
            //Release button
            while (prevCommandList.Count > 0)
            {
                string keycode = (string)prevCommandList.Dequeue();
                if( keycode == "up" || keycode == "down" || keycode == "right" || keycode == "left" )
                {
                    int cnt = localButtonHistory[keycode];
                    if (cnt % 2 == 0)
                    {
                        keyboard.SendKeyCode(ConvertKeyPress(keycode.ToLower()), false);
                    }
                }
                else
                {

                    keyboard.SendKeyCode(ConvertKeyPress(keycode.ToLower()), false);
                }
            }

            //Press button down
            while (commandList.Count > 0)
            {
                string cmd = (string)commandList.Dequeue();
                cmd = cmd.Replace(".", "");
                string[] cmdSplit = cmd.Split(';');
                string user = cmdSplit[0];
                string keycode = cmdSplit[1].Replace(".", "");

                VerifyKeys(keyboard, user, keycode);
                
            }
        }
    }
}
