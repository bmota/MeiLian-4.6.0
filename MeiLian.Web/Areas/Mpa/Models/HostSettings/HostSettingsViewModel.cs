using System.Collections.Generic;
using Abp.Application.Services.Dto;
using MeiLian.Configuration.Host.Dto;

namespace MeiLian.Web.Areas.Mpa.Models.HostSettings
{
    public class HostSettingsViewModel
    {
        public HostSettingsEditDto Settings { get; set; }

        public List<ComboboxItemDto> EditionItems { get; set; }

        public List<ComboboxItemDto> TimezoneItems { get; set; }
    }
}
