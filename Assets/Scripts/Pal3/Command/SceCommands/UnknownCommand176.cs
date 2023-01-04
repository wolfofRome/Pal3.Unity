﻿// ---------------------------------------------------------------------------------------------
//  Copyright (c) 2021-2023, Jiaqi Liu. All rights reserved.
//  See LICENSE file in the project root for license information.
// ---------------------------------------------------------------------------------------------

namespace Pal3.Command.SceCommands
{
    #if PAL3A
    [AvailableInConsole]
    [SceCommand(176, "南宫煌开启摄灵法阵")]
    public class UnknownCommand176 : ICommand
    {
        public UnknownCommand176(
            int unknown1,
            int unknown2,
            int unknown3)
        {
            Unknown1 = unknown1;
            Unknown2 = unknown2;
            Unknown3 = unknown3;
        }

        public int Unknown1 { get; }
        public int Unknown2 { get; }
        public int Unknown3 { get; }
    }
    #endif
}