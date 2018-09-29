using Core.Common.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Common.Core
{
    public class TempObjectBase : INotifyPropertyChanged
    {
        private event PropertyChangedEventHandler propertyChanged;

        List<PropertyChangedEventHandler> propertyChangedSubscribers
            = new List<PropertyChangedEventHandler>();

        public event PropertyChangedEventHandler PropertyChanged
        {
            add
            {
                if (!propertyChangedSubscribers.Contains(value))
                {
                    propertyChanged += value;
                    propertyChangedSubscribers.Add(value);
                }
            }
            remove
            {
                propertyChanged -= value;
                propertyChangedSubscribers.Remove(value);
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            OnPropertyChanged(propertyName, true);
        }

        protected virtual void OnPropertyChanged(string propertyName, bool makeDirty)
        {
            if (propertyChanged != null)
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            
            if (makeDirty)
                isDirty = true;
        }

        protected virtual void OnPropertyChanged<T>(Expression<Func<T>> propertyExpression)
        {
            string propertyName = PropertySupport.ExtractPropertyName(propertyExpression);
            OnPropertyChanged(propertyName);
        }

        bool isDirty;

        public bool IsDirty
        {
            get { return isDirty; }
        }
    }
}
