using MiskCore.Playables.Module.IdleBase;
using UnityEngine;
using UnityEngine.Playables;

namespace MiskCore.Playables.Module.IdleBase.StateMachine
{
    public interface IIdleBaseStateInfo
    {

        /// <summary>
        /// �����A���ݾ����A
        /// </summary>
        public IIdlePlayable IdlePlayable { get; }

        /// <summary>
        /// �i�J���A�ɪ� Playable
        /// </summary>
        public Playable StartPlayable { get; }

        /// <summary>
        /// ���}���A�ɪ� Playable
        /// </summary>
        public Playable ExitPlayable { get; }
    }

}

