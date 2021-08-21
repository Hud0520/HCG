using System;
using System.Collections.Generic;
using System.Text;

namespace Nhom21.Object
{
    class Helper
    {
        public static Rule getRuleById(List<Rule> list, string id)
        {
            foreach (var item in list)
            {
                if (id.Equals(item.id))
                {
                    return item;
                }
            }
            return null;
        }

        public static Event getEventById(List<Event> list, string id)
        {
            foreach (var item in list)
            {
                if (id.Equals(item.id))
                {
                    return item;
                }
            }
            return null;
        }
    }
}
