using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace UIFrameWork
{
    public abstract class BaseItem : MonoBehaviour
    {
        public enum EnumState
        {
            /// <summary>
            /// 未加载
            /// </summary>
            None,
            /// <summary>
            ///遮挡
            /// </summary>
            Hide,
            /// <summary>
            /// 显示
            /// </summary>
            Show,
            /// <summary>
            /// 被遮挡
            /// </summary>
            Pause,
        }
        public EnumState State
        {
            get;
            protected set;
        }
        public bool CanBeDestory=true ;
        public virtual void ShowItem(Action OnDone = null)
        {
            State = EnumState.Show;
            if (!this.gameObject.activeSelf)
            {
                gameObject.SetActive(true);
            }
            if (OnDone != null)
            {
                OnDone();
            }
        }
        public virtual void HideItem(Action OnDone = null)
        {
            State = EnumState.Hide;
            if (this.gameObject.activeSelf)
            {
                gameObject.SetActive(false);
            }
            if (OnDone != null)
            {
                OnDone();
            }
        }
        public virtual void PauseItem(Action OnDone = null)
        {
            State = EnumState.Pause;
            if (!this.gameObject.activeSelf)
            {
                gameObject.SetActive(true);
            }
            if (OnDone != null)
            {
                OnDone();
            }

        }
        public virtual void ResumeItem(Action OnDone = null)
        {
            State = EnumState.Show;
            if (!gameObject.activeSelf)
            {
                gameObject.SetActive(true);
            }
            if (OnDone != null)
            {
                OnDone();
            }
        }
        public virtual void RemoveItem(Action OnDone)
        {
            if (CanBeDestory)
                Destroy(this.gameObject);

        }
    }
}
