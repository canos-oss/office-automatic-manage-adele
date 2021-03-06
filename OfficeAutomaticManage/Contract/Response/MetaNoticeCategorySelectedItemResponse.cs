using Canos.OfficeAutomatic.Contract.Vo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Canos.OfficeAutomatic.Contract.Response
{
    public class MetaNoticeCategorySelectedItemResponse : BaseResponse
    {
        [JsonProperty("item")]
        public MetaNoticeCategoryVo Item { get; set; }
    }
}
