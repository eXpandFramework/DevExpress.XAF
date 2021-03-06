﻿using DevExpress.EasyTest.Framework;
using Xpand.TestsLib.Common.EasyTest.Commands.ActionCommands;

namespace Xpand.TestsLib.Common.EasyTest.Commands{
	public class LogOffCommand:EasyTestCommand{
		protected override void ExecuteCore(ICommandAdapter adapter){
			new ActionCommand("Log Off").Execute(adapter);
		}
	}
}