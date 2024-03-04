using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Principios_SOLID.DependencyInversion
{

    public class DependencyInv
    {

        public async void Main()
        {
            IInfo info = new InfoByFile("posts.json");
            string origin = "https://jsonplaceholder.typicode.com/todos";
            Monitor monitor = new Monitor(origin, info);
            await monitor.Show();
        }

        public class Post
        {
            public int userId { get; set; }
            public int id { get; set; }
            public string title { get; set; } = string.Empty;
            public bool completed { get; set; }
        }

        public class InfoByFile : IInfo
        {
            private string _path;
            public InfoByFile(string path)
            {
                _path = path;
            }
            public async Task<IEnumerable<Post>> GetInfo()
            {
                using (var contentStream = new FileStream(_path, FileMode.Open, FileAccess.Read))
                {
                    IEnumerable<Post> posts = await JsonSerializer.DeserializeAsync<IEnumerable<Post>>(contentStream);

                    return posts ?? new List<Post>();
                }
            }
        }

        public class Monitor
        {
            private string _origin;
            //Añadimos la interfaz como parámetro
            private IInfo _info;
            public Monitor(string origin, IInfo info)
            {
                _origin = origin;
                _info = info;
            }

            public async Task Show()
            {
                //ya no dependemos de la instancia InfoByFile
                var posts = await _info.GetInfo();

                foreach (var post in posts)
                {
                    Console.WriteLine($"title: {post.title}");
                }
            }
        }

        public interface IInfo
        {
            public Task<IEnumerable<Post>> GetInfo();
        }
    }
}
