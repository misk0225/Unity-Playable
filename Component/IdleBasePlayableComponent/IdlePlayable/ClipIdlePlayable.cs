using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;


namespace MiskCore.Playables.Module.IdleBase
{
    /// <summary>
    /// �Τ@�� clip ��@�ݾ��ʵe
    /// </summary>
    public struct ClipIdlePlayable : IIdlePlayable
    {
        public Playable Playable { get; private set; }

        public ClipIdlePlayable(PlayableGraph graph, AnimationClip clip)
        {
            Playable = AnimationClipPlayable.Create(graph, clip);
        }
    }

}
