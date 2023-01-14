using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10.models
{
    /// <summary>
    /// Менеджер
    /// </summary>
    public class Manager : Worker
    {
        public Manager(ref ObservableCollection<Client> clients) : base(ref clients)
        {
        }
    }
}
