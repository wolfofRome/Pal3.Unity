// ---------------------------------------------------------------------------------------------
//  Copyright (c) 2021-2023, Jiaqi Liu. All rights reserved.
//  See LICENSE file in the project root for license information.
// ---------------------------------------------------------------------------------------------

namespace Pal3.Command.SceCommands
{
    [AvailableInConsole]
    [SceCommand(43, "增减好感增，" +
                    "参数：角色ID，增减值")]
    public class FavorAddCommand : ICommand
    {
        public FavorAddCommand(int actorId, int changeAmount)
        {
            ActorId = actorId;
            ChangeAmount = changeAmount;
        }

        public int ActorId { get; }
        public int ChangeAmount { get; }
    }
}