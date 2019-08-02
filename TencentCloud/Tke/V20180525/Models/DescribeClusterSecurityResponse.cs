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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeClusterSecurityResponse : AbstractModel
    {
        
        /// <summary>
        /// 集群的账号名称
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 集群的访问密码
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// 集群访问CA证书
        /// </summary>
        [JsonProperty("CertificationAuthority")]
        public string CertificationAuthority{ get; set; }

        /// <summary>
        /// 集群访问的地址
        /// </summary>
        [JsonProperty("ClusterExternalEndpoint")]
        public string ClusterExternalEndpoint{ get; set; }

        /// <summary>
        /// 集群访问的域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 集群Endpoint地址
        /// </summary>
        [JsonProperty("PgwEndpoint")]
        public string PgwEndpoint{ get; set; }

        /// <summary>
        /// 集群访问策略组
        /// </summary>
        [JsonProperty("SecurityPolicy")]
        public string[] SecurityPolicy{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "CertificationAuthority", this.CertificationAuthority);
            this.SetParamSimple(map, prefix + "ClusterExternalEndpoint", this.ClusterExternalEndpoint);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "PgwEndpoint", this.PgwEndpoint);
            this.SetParamArraySimple(map, prefix + "SecurityPolicy.", this.SecurityPolicy);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

