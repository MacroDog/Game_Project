using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UIFrameWork
{
    public abstract class UIModule : MonoBehaviour
    {
        protected Dictionary<UIType, BaseUI> baseUIDic = new Dictionary<UIType, BaseUI>();
        protected Dictionary<string, BaseItem> baseItemDic = new Dictionary<string, BaseItem>();


        /// <summary>
        /// 初始化
        /// </summary>
        protected virtual void InitUI()
        {
            baseUIDic.Clear();
            foreach (var item in baseItemDic.Values)
            {
                DestroyImmediate(item);
            }
            baseItemDic.Clear();
        }

    }
}
