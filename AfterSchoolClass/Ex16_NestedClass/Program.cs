using System;
using System.Collections.Generic;

namespace Class08_NestedClass
{
    class Configuration
    {
        List<ItemValue> listConfig = new List<ItemValue>();

        public void SetConfig(string item, string value)
        {
            ItemValue iv = new ItemValue();
            iv.SetValue(this, item, value);
        }

        public string GetConfig(string item)
        { 
            foreach (ItemValue iv in listConfig)
            {
                if (iv.GetItem() == item)
                    return iv.GetValue();
            }
            return "";
        }

        /* 중첩 클래스 inner class */
        private class ItemValue
        {
            private string item;
            private string value;

            // listConfig 리스트의 기존 객체 수정 또는 새로운 객체 추가
            public void SetValue(Configuration config, string item, string value)
            {
                // 새로운 ItemValue 객체에 새로운 item, value값 저장
                this.item = item;
                this.value = value;

                // 이미 존재하는 item 이라면 value값을 수정하고, 그렇지 않으면 listConfig에 추가한다.
                bool found = false;
                for (int i = 0; i < config.listConfig.Count; i++)
                {
                    if (config.listConfig[i].item == item)
                    {
                        config.listConfig[i] = this;
                        found = true;
                        break;
                    }
                }

                // 존재하지 않는 item이라면 listConfig에 추가
                if (found == false)
                    config.listConfig.Add(this);
            }

            public string GetItem()
            { return item; }
            
            public string GetValue()
            { return value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Configuration config = new Configuration();
            config.SetConfig("Version", "V 5.0");
            config.SetConfig("Size", "655,324 KB");

            Console.WriteLine(config.GetConfig("Version"));
            Console.WriteLine(config.GetConfig("Size"));

            config.SetConfig("Version", "V 5.0.1");
            Console.WriteLine(config.GetConfig("Version"));
        }
    }
}
