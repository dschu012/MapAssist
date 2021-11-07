using MapAssist.Helpers;
using MapAssist.Interfaces;
using System;

namespace MapAssist.Types
{
    public class ActMisc : IUpdatable<ActMisc>
    {
        IntPtr _pActMisc = IntPtr.Zero;
        private Structs.ActMisc _actMisc;

        public ActMisc(IntPtr pActMisc)
        {
            _pActMisc = pActMisc;
            Update();
        }

        public ActMisc Update()
        {
            using (var processContext = GameManager.GetProcessContext())
            {
                _actMisc = processContext.Read<Structs.ActMisc>(_pActMisc);
            }
            return this;
        }

        public Difficulty GameDifficulty { get => _actMisc.GameDifficulty; }
        public Act Act { get => new Act(_actMisc.pAct); }
        public Level LevelFirst { get => new Level(_actMisc.pLevelFirst); }
        public Area RealTombArea { get => _actMisc.RealTombArea;  }
    }
}
