using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_10
{
    public interface IResource
    {
        void AccessResource();
    }

    
    public class ConcreteResource : IResource
    {
        public void AccessResource()
        {
            MessageBox.Show("Correct");
        }
    }

   
    public class ResourceProxy : IResource
    {
        private ConcreteResource resource;
        private string username;
        private string password;

        public ResourceProxy(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public void AccessResource()
        {
            if (Authenticate())
            {
                resource = new ConcreteResource();
                resource.AccessResource();
            }
            else
            {
                MessageBox.Show("Wrong");
            }
        }

        private bool Authenticate()
        {
            return username == "1" && password == "1";

        }
    }
}
