using System;
using System.Collections.Generic;
using System.Text;
using VirtualBox;
using System.Threading;
using System.Reflection;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
//using System.IO.Pipes;
using System.Security.Principal;
using System.Diagnostics;
using System.Threading;
using System.Collections;

namespace TwitchChatPipe
{
    public class VBox
    {
        IVirtualBox vb;
        ISession sess;
        IMachine m;

        Queue commandList = new Queue();
        Queue prevCommandList = new Queue();
        public bool isAttached = true;
        public Form1 parent;


        public VBox(string vmName, Form1 p)
        {
            vb = new VirtualBox.VirtualBoxClass();
            sess = new VirtualBox.SessionClass();
            parent = p;

            m = vb.FindMachine(vmName);
        }

       
        public void MachineLoop()
        {
            m.LockMachine((Session)sess, LockType.LockType_Shared);

            try
            {
                VBoxKeyboardHelper keyboard = new VBoxKeyboardHelper(sess.Console.Keyboard);

                while (true)
                {
                    parent.bm.Update(keyboard);

                    lock (this)
                    {
                        if (!isAttached) break;
                    }

                    Thread.Sleep(10);
                }
            }
            finally
            {
                sess.UnlockMachine();
            }
        }

     
        public void VBoxWaitComplete(IProgress p)
        {
            uint prev = 0;
            while (p.Completed == 0)
            {
                if (p.Percent != prev) Console.Write("{0}% ", p.Percent);
                prev = p.Percent;
                p.WaitForCompletion(5000);
            }
            if (p.ResultCode == 0)
            {
                Console.WriteLine("done");
            }
            else
            {
                Console.WriteLine("Error {0} {1}", p.ErrorInfo.ResultCode, p.ErrorInfo.Text);
                throw new COMException(p.ErrorInfo.Text, p.ErrorInfo.ResultCode);
            }
        }
    }
}
