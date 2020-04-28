/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProxyGroupDetail : AbstractModel
    {
        
        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// 通道组中通道数量
        /// </summary>
        [JsonProperty("ProxyNum")]
        public long? ProxyNum{ get; set; }

        /// <summary>
        /// 通道组状态：
        /// 0表示正常运行；
        /// 1表示创建中；
        /// 4表示销毁中；
        /// 11表示迁移中；
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 归属Uin
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// 创建Uin
        /// </summary>
        [JsonProperty("CreateUin")]
        public string CreateUin{ get; set; }

        /// <summary>
        /// 通道名称
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// 通道组域名解析默认IP
        /// </summary>
        [JsonProperty("DnsDefaultIp")]
        public string DnsDefaultIp{ get; set; }

        /// <summary>
        /// 通道组域名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 目标地域
        /// </summary>
        [JsonProperty("RealServerRegionInfo")]
        public RegionDetail RealServerRegionInfo{ get; set; }

        /// <summary>
        /// 是否老通道组，2018-08-03之前创建的通道组为老通道组
        /// </summary>
        [JsonProperty("IsOldGroup")]
        public bool? IsOldGroup{ get; set; }

        /// <summary>
        /// 通道组ID
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 标签列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TagSet")]
        public TagPair[] TagSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ProxyNum", this.ProxyNum);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "CreateUin", this.CreateUin);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "DnsDefaultIp", this.DnsDefaultIp);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamObj(map, prefix + "RealServerRegionInfo.", this.RealServerRegionInfo);
            this.SetParamSimple(map, prefix + "IsOldGroup", this.IsOldGroup);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamArrayObj(map, prefix + "TagSet.", this.TagSet);
        }
    }
}
