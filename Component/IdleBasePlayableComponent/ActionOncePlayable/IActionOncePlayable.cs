using UnityEngine.Animations;
using UnityEngine.Playables;


namespace MiskCore.Playables.Module.IdleBase
{
    /// <summary>
    /// ����@���ʵe���f
    /// �ݴ��Ѱʵe�V�X�欰�P�I�s�����ɾ�
    /// </summary>
    public interface IActionOncePlayable
    {

        /// <summary>
        /// �}�l�V�X�ɰѻP�� Playable
        /// </summary>
        public Playable StartMixPlayable { get; }

        /// <summary>
        /// ��}�l�i��
        /// </summary>
        public void OnStart(IdleBaseComponent component, AnimationMixerPlayable mixerPlayable);

        /// <summary>
        /// �i�J�V�X Update
        /// </summary>
        public void OnUpdate(float deltaTime);

        /// <summary>
        /// �I�s�����ʵe
        /// </summary>
        public bool ExitCondition();

        /// <summary>
        /// �������}
        /// </summary>
        public void OnExit();

        /// <summary>
        /// ��欰�Q�Ȱ�
        /// </summary>
        public void OnPause();

        /// <summary>
        /// ��欰�Q�q���~��
        /// </summary>
        public void OnContinue();
    }
}
