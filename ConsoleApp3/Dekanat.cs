using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Dekanat
    {
        private string fakyltet;
        private Group[] groups;

        public Dekanat(string fakyltet)
        {
            this.fakyltet = fakyltet;
            this.groups = new Group[0];
        }

        public string createGroup(Group new_group)
        {
            int kol = groups.Length;
            Group[] new_groups = new Group[kol + 1];
            for (int i = 0; i < kol; i++)
                new_groups[i] = this.groups[i];
            new_groups[kol] = new_group;
            this.groups = new_groups;
            return ("создана новая группа на факультете "+new_group.Number);
        }

        public string deleteGroup(String nomer)
        {
            int kol = groups.Length;
            for (int i=0;i<kol;i++)
                if (groups[i].Number==nomer)
                {
                    Group[] new_groups = new Group[kol - 1];
                    for (int j = 0; j < i; j++)
                        new_groups[i] = groups[i];
                    for (int j = i; j < kol - 1; j++)
                        new_groups[j] = this.groups[j + 1];
                    return ("Группа " + nomer + " была закрыта");
                }
            return ("Такой группы не существует");
        }

    }
}
