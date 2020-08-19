using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PacManGameSample
{
    public class Map
    {
        List<Cell> cells;
        public Map()
        {
            cells = new List<Cell>();
        }

        public List<Cell> LoadMap(string jsonPath)
        {
            using (StreamReader r = new StreamReader(jsonPath))
            {
                string json = r.ReadToEnd();
                List<Cell> cells = JsonConvert.DeserializeObject<List<Cell>>(json);

                if (cells != null)
                    return cells;
                return new List<Cell>();
            }
        }
    }
}
