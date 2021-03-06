﻿/*----------------------------------------------------------------
    Copyright (C) 2015 Senparc
    
    文件名：GetMediaListResultJson.cs
    文件功能描述：获取素材列表返回结果
    
    
    创建标识：Senparc - 20150324
----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Senparc.Weixin.MP.AdvancedAPIs.GroupMessage;
using Senparc.Weixin.MP.Entities;

namespace Senparc.Weixin.MP.AdvancedAPIs.Media
{
    /// <summary>
    /// 获取素材总数返回结果
    /// </summary>
    public class BaseMediaListResultJson : WxJsonResult
    {
        /// <summary>
        /// 该类型的素材的总数
        /// </summary>
        public int total_count { get; set; }
        /// <summary>
        /// 本次调用获取的素材的数量
        /// </summary>
        public int item_count { get; set; }
    }

    /// <summary>
    /// 图文素材的Item
    /// </summary>
    public class MediaList_NewsResult : BaseMediaListResultJson
    {
        public List<MediaList_News_Item> item { get; set; }
    }

    public class MediaList_News_Item
    {
        public string media_id { get; set; }
        public Media_News_Content content { get; set; }
    }

    public class Media_News_Content
    {
        public List<NewsModel> news_item { get; set; } 
    }

    /// <summary>
    /// 除图文之外的其他素材的Item
    /// </summary>
    public class MediaList_OthersResult : BaseMediaListResultJson
    {
        public List<MediaList_Others_Item> item { get; set; }
    }

    public class MediaList_Others_Item
    {
        public string media_id { get; set; }
        /// <summary>
        /// 文件名称
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 这篇图文消息素材的最后更新时间
        /// </summary>
        public string update_time { get; set; }
    }
}
