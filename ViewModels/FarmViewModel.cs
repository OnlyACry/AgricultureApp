using AgricultureApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AgricultureApp.Models.ErrorModel;

namespace AgricultureApp.ViewModels
{
    public class FarmViewModel
    {
        public List<string> CameraList { get; set; } = new List<string>
        {
            //绑定图片资源
            "dp_1.jpg","dp_2.jpg","dp.jpg","dp.jpg"
        };

        public List<ErrorModel> Errorlist { get; set; } = new List<ErrorModel>();

        public List<MonitorModel> MonitorList { get; set; } = new List<MonitorModel>();

        public FarmViewModel() 
        {
            Errorlist.Add(new ErrorModel
            {
                Header = "病虫害",
                Description = "小麦叶锈病",
                Address = "田间1号",
                Color = "#EC7044"

            });

            Errorlist.Add(new ErrorModel
            {
                Header = "棚内温度过高",
                Description = "超过标准值3℃",
                Address = "温室大棚1",
                Color = "Orange"
            });

            MonitorList.Add(new MonitorModel { Header = "室外温度", Value = 30, Unit = "℃", Icon = "\ue610" , TextColor = "Green"});
            MonitorList.Add(new MonitorModel { Header = "室外湿度", Value = 96.7, Unit = "%", Icon = "\ue60a", ChangeFlag = 1, ChangeValue = 6, TextColor = "#FE7C60" });
            MonitorList.Add(new MonitorModel { Header = "风向", Value = "正东", Icon = "\ue63d", TextColor = "Green" });
            MonitorList.Add(new MonitorModel { Header = "瞬时风速", Value = "20", Unit = "m/s", Icon = "\ue64d", TextColor = "Green" });
            MonitorList.Add(new MonitorModel { Header = "瞬时雨量", Value = "30", Unit = "m3", Icon = "\ue622", TextColor = "Green" });
            MonitorList.Add(new MonitorModel { Header = "紫外线强度", Value = "10", Unit = "μW/cm2", Icon = "\ue603" , TextColor = "Green" });
            MonitorList.Add(new MonitorModel { Header = "光照强度", Value = "10", Unit = "Lux", Icon = "\ue898" , TextColor = "Green" });
            MonitorList.Add(new MonitorModel { Header = "气压", Value = "1", Unit = "kPa", Icon = "\ue6c0" , TextColor = "Green" });


        }
    }
}
