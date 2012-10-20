/**
\author		Shestakov Mikhail aka MIKE
\date		14.10.2012 (c)Andrey Korotkov

This file is a part of DGLE2 project and is distributed
under the terms of the GNU Lesser General Public License.
See "DGLE2.h" for more details.
*/
using System;
using Gtk;

namespace FontTool
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Application.Init ("FontTool", ref args);
			FontStyleWindow win = new FontStyleWindow();
			win.Show();
			Application.Run();
		}
	}
}