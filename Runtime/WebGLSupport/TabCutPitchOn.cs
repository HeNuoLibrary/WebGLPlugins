// -----------------------------------------------
// Copyright © GameFramework. All rights reserved.
// CreateTime: 2022/8/16   13:44:30
// -----------------------------------------------


using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

namespace GameFrame.Hotfix
{
    public class TabCutPitchOn : MonoBehaviour
    {
        [SerializeField] private GameObject[] dicObj;
        // 得到EventSystem组件
        private EventSystem system;
        // 用于存储得到的字典的索引
        private int index;

        void Start()
        {
            // 初始化字段
            system = EventSystem.current;
            index = 0;
        }

        void Update()
        {
            // 当有 UI 高亮(得到高亮的UI，不为空)并且 按下Tab键
            if (system.currentSelectedGameObject != null && Input.GetKeyDown(KeyCode.Tab))
            {
                Debug.Log(system.currentSelectedGameObject.name);

                // 得到当前高亮状态的 UI 物体
                GameObject hightedObj = system.currentSelectedGameObject;
                // 看是场景中第几个物体
                for (int i = 0; i < dicObj.Length; i++)
                {
                    if (dicObj[i] == hightedObj)
                    {
                        index = i + 1;
                        break;
                    }
                }
                if (index > dicObj.Length - 1) index = 0;
                // 得到对应索引的游戏物体
                GameObject obj = dicObj[index];
                // 使得到的游戏物体高亮
                system.SetSelectedGameObject(obj, new BaseEventData(system));
            }
        }
    }
}