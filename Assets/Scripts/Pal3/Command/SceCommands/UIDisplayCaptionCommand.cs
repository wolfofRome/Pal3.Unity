// ---------------------------------------------------------------------------------------------
//  Copyright (c) 2021-2022, Jiaqi Liu. All rights reserved.
//  See LICENSE file in the project root for license information.
// ---------------------------------------------------------------------------------------------

namespace Pal3.Command.SceCommands
{
    #if PAL3
    [SceCommand(86, "显示全屏字幕（例如显示诗句等），" +
                    "参数：字幕序号（对应美术图片，每个字幕一个图片）")]
    public class UIDisplayCaptionCommand : ICommand
    {
        public UIDisplayCaptionCommand(string textureName, int numberOfLines)
        {
            TextureName = textureName;
            NumberOfLines = numberOfLines;
        }

        public string TextureName { get; }
        public int NumberOfLines { get; }
    }
    #elif PAL3A
    [SceCommand(86, "显示全屏字幕（例如显示诗句等），" +
                    "参数：字幕序号（对应美术图片，每个字幕一个图片）")]
    public class UIDisplayCaptionCommand : ICommand
    {
        public UIDisplayCaptionCommand(string textureName, int numberOfLines, int unknown)
        {
            TextureName = textureName;
            NumberOfLines = numberOfLines;
            Unknown = unknown;
        }

        public string TextureName { get; }
        public int NumberOfLines { get; }
        public int Unknown { get; }
    }
    #endif
}