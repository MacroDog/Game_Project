using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
namespace UIFrameWork
{
    public abstract class BaseUI : BaseItem
    {
        public BaseUIInfo Info
        {
            get;set;
        }
        public abstract void ShowUI();
        public abstract void HideUI();
        public virtual void PauseUI()
        {

        } 

        public virtual void ResumeUI()
        {

        }
        public virtual void SetData()
        {

        }
        public virtual void ResetData()
        {

        }
        /// <summary>
        /// 界面显示
        /// </summary>
        public virtual void BeforeShow()
        {
        }
        /// <summary>
        /// 显示界面时
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name=""></param>
        public virtual void OnShow<T>(List<BaseItem> list, Action<T> OnDone = null) where T:BaseUI
        {
            ShowUI();
            if (OnDone!=null)
            {
                OnDone(this as T);
            }
            SetData();
        }
        public virtual void BeforeHide()
        {
        }


    }
}
