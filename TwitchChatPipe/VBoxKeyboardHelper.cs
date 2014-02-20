using System;
using VirtualBox;
using System.Windows.Forms;

namespace TwitchChatPipe
{
	public class VBoxKeyboardHelper {
		public IKeyboard Keyboard { get; private set; }

		public VBoxKeyboardHelper(IKeyboard kb) {
			Keyboard = kb;
		}

		public void SendKeyCode(Keys keycode, bool down) {
			int code;
			//Console.WriteLine("VBoxKeyboardHelper.SendKeyCode({1}={2},{0})", down, keycode, (int)keycode);
			int[] codes_az = { 0x1e, 0x30, 0x2e, 0x20, 0x12, 0x21, 0x22, 0x23, 0x17, 0x24, 0x25, 0x26, 0x32, 0x31, 0x18, 0x19, 0x10, 0x13, 0x1f, 0x14, 0x16, 0x2f, 0x11, 0x2d, 0x15, 0x2c }; //a-z
			int[] codes_num = {0x0b, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0a}; //0123456789
			int[] codes_Fkeys = { 0x3b, 0x3c, 0x3d, 0x3e, 0x3f, 0x40, 0x41, 0x42, 0x43, 0x44, 0x57, 0x58 }; //F123456789,10,11,12
			if (keycode >= Keys.A && keycode <= Keys.Z) {
				code = codes_az[keycode - Keys.A];
			} else if (keycode >= Keys.D0 && keycode <= Keys.D9) {
				code = codes_num[keycode - Keys.D0];
			} else if (keycode >= Keys.F1 && keycode <= Keys.F12) {
				code = codes_Fkeys[keycode - Keys.F1];
			} else {
				switch (keycode) {
					case Keys.Space: code = 0x39; break; //0x0239;
					case Keys.Left: code = 0xe04b; break;
					case Keys.Up: code = 0xe048; break;
					case Keys.Right: code = 0xe04d; break;
					case Keys.Down: code = 0xe050; break;
					case Keys.Enter: code = 0x1c; break;
					case Keys.LShiftKey:
					case Keys.RShiftKey:
					case Keys.ShiftKey: code = 0x2a; break;
					case Keys.Tab: code = 0x0f; break;
					case Keys.Back: code = 0x0e; break;
					case Keys.Escape: code = 0x01; break;
					case Keys.Home: code = 0xe047; break;
					case Keys.PageUp: code = 0xe049; break;
					case Keys.PageDown: code = 0xe051; break;
					case Keys.End: code = 0xe04f; break;
					case Keys.Insert: code = 0xe052; break;
					case Keys.ControlKey:
					case Keys.LControlKey: code = 0x1d; break;
					case Keys.RControlKey: code = 0xe01d; break;
					case Keys.Menu:
					case Keys.LMenu: code = 0x38; break; //Left Alt
					case Keys.RMenu: code = 0xe038; break; //Right Alt
					case Keys.LWin: code = 0xe05b; break; //Left windows key
					case Keys.RWin: code = 0xe05c; break; //Right windows key
					case Keys.Delete: code = 0xe053; break;
					case Keys.OemQuotes: code = 0x28; break;
					case Keys.OemQuestion: code = 0x35; break;
					case Keys.OemPeriod: code = 0x34; break;
					case Keys.OemMinus: code = 0x0c; break;
					case Keys.Oemplus: code = 0x0d; break;
					case Keys.Oemcomma: code = 0x33; break;
					case Keys.OemSemicolon: code = 0x27; break;
					case Keys.Oemtilde: code = 0x29; break;
					case Keys.OemCloseBrackets: code = 0x1b; break;
					case Keys.OemBackslash: code = 0x2b; break;
					case Keys.OemOpenBrackets: code = 0x1a; break;
					default:
						Console.Error.WriteLine("VBoxKeyboardHelper.SendKeyCode({1}={2},{0}) unknown key", down, keycode, (int)keycode);
						return;
				}
			}
			if ((code & 0xff00) != 0) kbdPutCode((code >> 8) & 0xff);
			kbdPutCode((code & 0xff) | (down ? 0 : 0x80));
		}
		private void kbdPutCode(int code) {
			try {
				Keyboard.PutScancode(code);
			} catch (Exception ex) {
				Console.Error.WriteLine("VBoxKeyboardHelper.PutScancode Exception: {0}", ex.ToString());
			}
		}
	}
}
