using UnityEngine.Playables;


namespace MiskCore.Playables.Module.IdleBase
{
    /// <summary>
    /// �ݾ��� Playable ���f
    /// </summary>
    public interface IIdlePlayable
    {
        /// <summary>
        /// �D�n���ݾ� Playable
        /// �����O Loop ���A
        /// </summary>
        public Playable Playable { get; }

    }

}

