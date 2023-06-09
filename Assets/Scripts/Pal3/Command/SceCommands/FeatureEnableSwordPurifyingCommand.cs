﻿// ---------------------------------------------------------------------------------------------
//  Copyright (c) 2021-2023, Jiaqi Liu. All rights reserved.
//  See LICENSE file in the project root for license information.
// ---------------------------------------------------------------------------------------------

namespace Pal3.Command.SceCommands
{
    #if PAL3
    [AvailableInConsole]
    [SceCommand(109, "打开或关闭魔剑养成功能，" +
                     "参数：0关闭1打开")]
    public class FeatureEnableSwordPurifyingCommand : ICommand
    {
        public FeatureEnableSwordPurifyingCommand(int enable)
        {
            Enable = enable;
        }

        public int Enable { get; }
    }
    #endif
}