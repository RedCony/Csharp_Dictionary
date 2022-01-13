using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Dictionary
{
    class App
    {
        public App()
        {
            string Quest = File.ReadAllText("./QuestList.json");
          // Console.WriteLine(Quest);

            ItemData[] Questdatas = JsonConvert.DeserializeObject<ItemData[]>(Quest);

            Dictionary<int,ItemData> dicItemDatas = new Dictionary<int,ItemData>();

            foreach (ItemData itemData in Questdatas)
            {
                //Console.WriteLine("{0},{1},{2},{4}", itemData.ID, itemData.name,itemData.level,itemData.goal);
                dicItemDatas.Add(itemData.ID,itemData);
            }

            foreach (KeyValuePair<int, ItemData> kv in dicItemDatas)
            {
                Console.WriteLine(
                    "\nID:{0},\nName:{1},\nLevel:{2},\nGoal:{3}"
                    , kv.Key, kv.Value.name,kv.Value.level,kv.Value.goal);
            }

            /*
            string json = File.ReadAllText("./itemdata.json");
            Console.WriteLine(json);

            ItemData[] itemdatas = JsonConvert.DeserializeObject<ItemData[]>(json);

            Dictionary<int, ItemData> dicItemDatas = new Dictionary<int, ItemData>();

            foreach (ItemData itemData in itemdatas)
            {
                Console.WriteLine("{0},{1}", itemData.ID, itemData.name);
                dicItemDatas.Add(itemData.ID, itemData);
            }

            ItemData data = dicItemDatas[100];
            Console.WriteLine("{0},{1}", data.ID, data.name);

            /*
           // Console.WriteLine("Hello World!");
            Dictionary<int,string> dic = new Dictionary<int,string>();

            dic.Add(100,"장검");
            dic.Add(101,"단검");
            dic.Add(102,"활");


            foreach(KeyValuePair<int,string> kv in dic)
            {
                Console.WriteLine("key:{0},value:{1}", kv.Key, kv.Value);
            }
            */
        }
    }
}
