using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetQuestionProject
{
    public class Person
    {
        private string name;

        // Event to handle name change
        public event EventHandler<NameChangedEventArgs> NameChanged;

        public string Name
        {
            get => name;
            set
            {
                if (name != value)
                {
                    string oldName = name;
                    name = value;
                    OnNameChanged(oldName, name);
                }
            }
        }

        // Method to raise the NameChanged event
        protected virtual void OnNameChanged(string oldName, string newName)
        {
            NameChanged?.Invoke(this, new NameChangedEventArgs(oldName, newName));
        }
    }

    public class NameChangedEventArgs : EventArgs
    {
        public string OldName { get; }
        public string NewName { get; }

        public NameChangedEventArgs(string oldName, string newName)
        {
            OldName = oldName;
            NewName = newName;
        }
    }
}
