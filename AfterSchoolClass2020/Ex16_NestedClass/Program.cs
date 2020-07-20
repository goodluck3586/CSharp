using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex16_NestedClass
{
    class Configuration
    {
        List<ItemValue> list = new List<ItemValue>();

        // 새로운 ItemValue 객체를 생성하는 메소드
        public void SetConfig(string item, string value)
        {
            ItemValue iv = new ItemValue();
            iv.SetValue(this, item, value);
        }

        // item 매개변수에 해당하는 value값을 반환하는 메소드
        public string GetConfig(string item)
        {
            foreach(ItemValue iv in list)
            {
                if (iv.GetItem() == item)
                    return iv.GetValue();
            }
            return null;
        }

        class ItemValue
        {
            private string item, value;

            public void SetValue(Configuration config, string item, string value)
            {
                this.item = item;
                this.value = value;

                // 이미 존재하는 item이면 value만 수정
                bool found = false;
                for(int i=0; i<config.list.Count; i++)
                {
                    if(config.list[i].item == item)
                    {
                        config.list[i] = this;
                        found = true;
                        break;
                    }
                }

                // 이미 존재하는 item이 아니면 list에 Add
                if (found == false)
                    config.list.Add(this);
            }

            public string GetItem()
            {
                return item;
            }

            public string GetValue()
            {
                return value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Configuration config = new Configuration();
            config.SetConfig("version", "1.0.0");
            config.SetConfig("size", "3,000,000 KB");

            Console.WriteLine(config.GetConfig("version"));     // "1.0.0"
            Console.WriteLine(config.GetConfig("size"));        // "3,000,000 KB"

            config.SetConfig("version", "1.0.1");
            Console.WriteLine(config.GetConfig("version"));     // "1.0.1"
        }
    }
}
