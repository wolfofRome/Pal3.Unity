// ---------------------------------------------------------------------------------------------
//  Copyright (c) 2021-2023, Jiaqi Liu. All rights reserved.
//  See LICENSE file in the project root for license information.
// ---------------------------------------------------------------------------------------------

namespace Pal3.Command.SceCommands
{
    #if PAL3
    [AvailableInConsole]
    [SceCommand(156, "UI展示雪见图片")]
    public class UIDisplayXueJianPictureCommand : ICommand
    {
        public UIDisplayXueJianPictureCommand() {}
    }
    #endif
}