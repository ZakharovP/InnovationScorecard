using Lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Server
{
    public class Table
    {
        public DataTable ParamTable { private set; get; }
        public DataTable ScoreTable { private set; get; }
        /// <summary>
        /// Dictionary countries contains mapping of country name to country object
        /// </summary>
        private Dictionary<string, Country> countries = new Dictionary<string, Country>();
        private Dictionary<string, DataRow> paramTableName2Rows = new Dictionary<string, DataRow>();
        private Dictionary<string, DataRow> scoreTableName2Rows = new Dictionary<string, DataRow>();
        private bool[] scoreFilter = new bool[Utils.Categories.Length];
        public Table(DataGridView paramDataGridView, DataGridView scoreDataGridView)
        {
            ParamTable = new DataTable();
            ScoreTable = new DataTable();
            paramDataGridView.DataSource = ParamTable;
            scoreDataGridView.DataSource = ScoreTable;

            ParamTable.Columns.Add(Utils.CountryParam.Text, typeof(string));
            for (int i = 0; i < Utils.Categories.Length; i++)
            {
                ParamTable.Columns.Add(Utils.Categories[i].Text, typeof(int));
                paramDataGridView.Columns[i].ToolTipText = Utils.Categories[i].Description;
                scoreFilter[i] = true;
            }
            ScoreTable.Columns.Add(Utils.Rank.Text, typeof(int));
            ScoreTable.Columns.Add(Utils.CountryScore.Text, typeof(string));
            ScoreTable.Columns.Add("Score", typeof(decimal));
        }
        public bool Add(Country[] cs)
        {
            for (int i = 0; i < cs.Length; i++)
            {
                if (!Add(cs[i]))
                {
                    return false;
                }
            }
            UpdateScoreTable();
            return true;
        }
        private bool Add(Country country)
        {
            if (countries.ContainsKey(country.Name))
            {
                return false;
            }
            countries.Add(country.Name, country);
            DataRow row = ParamTable.NewRow();
            row[Utils.CountryParam.Text] = country.Name;
            Grade[] grades = country.GetGrades();
            for (int i = 0; i < grades.Length; i++)
            {
                row[Utils.Categories[i].Text] = grades[i].Score;
            }
            ParamTable.Rows.Add(row);
            paramTableName2Rows.Add(country.Name, row);
            return true;
        }
        public void UpdateScoreTable()
        {
            ScoreTable.Clear();
            scoreTableName2Rows.Clear();
            string[] names = new string[countries.Count];
            double[] scores = new double[countries.Count];
            int j = 0;
            foreach (KeyValuePair<string, Country> kv in countries)
            {
                names[j] = kv.Key;
                scores[j] = kv.Value.GetScore(scoreFilter);
                j++;
            }
            Array.Sort(scores, names);
            for (int i = 0; i < scores.Length; i++)
            {
                DataRow row = ScoreTable.NewRow();
                row[Utils.Rank.Text] = i + 1;
                row[Utils.CountryScore.Text] = names[scores.Length - i - 1];
                row[Utils.Score.Text] = decimal.Round((decimal)scores[scores.Length - i - 1], 3);
                ScoreTable.Rows.Add(row);
                scoreTableName2Rows.Add(names[scores.Length - i - 1], row);
            }
        }
        public void Remove(DataRow[] rows)
        {
            string[] names = new string[rows.Length];
            for (int i = 0; i < rows.Length; i++)
            {
                names[i] = (string)rows[i][Utils.CountryParam.Text];
            }
            Remove(names);
        }
        public void Remove(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                countries.Remove(names[i]);
                ScoreTable.Rows.Remove(scoreTableName2Rows[names[i]]);
                scoreTableName2Rows.Remove(names[i]);
                ParamTable.Rows.Remove(paramTableName2Rows[names[i]]);
                paramTableName2Rows.Remove(names[i]);
            }
            UpdateScoreTable();
        }
        public bool[] GetScoreFilter()
        {
            bool[] x = new bool[scoreFilter.Length];
            for (int i = 0; i < scoreFilter.Length; i++)
            {
                x[i] = scoreFilter[i];
            }
            return x;
        }
        public void Filter(bool[] newScoreFilter)
        {
            for (int i = 0; i < scoreFilter.Length; i++)
            {
                scoreFilter[i] = newScoreFilter[i];
            }
            UpdateScoreTable();
        }
        public void Filter(double minScore, double maxScore)
        {
            List<string> names = new List<string>();
            double score;
            foreach (KeyValuePair<string, Country> kv in countries)
            {
                score = kv.Value.GetScore(scoreFilter);
                if (score < minScore || score > maxScore)
                {
                    names.Add(kv.Key);
                }
            }
            Remove(names.ToArray());
        }
        public void GetMinMaxScore(out double minScore, out double maxScore)
        {
            double[] scores = new double[countries.Count];
            int j = 0;
            foreach (KeyValuePair<string, Country> kv in countries)
            {
                scores[j] = kv.Value.GetScore(scoreFilter);
                j = j + 1;
            }
            minScore = scores.Min();
            maxScore = scores.Max();
        }
        public void GetMinMaxCountry(out Country minCountry, out Country maxCountry)
        {
            int[][] scores = new int[Utils.Categories.Length][];
            for (int i = 0; i < Utils.Categories.Length; i++)
            {
                scores[i] = new int[countries.Count()];
            }
            int j = 0;
            foreach (KeyValuePair<string, Country> kv in countries)
            {
                Grade[] grades = kv.Value.GetGrades();
                for (int i = 0; i < Utils.Categories.Length; i++)
                {
                    scores[i][j] = grades[i].Score;
                }
                j++;
            }
            Grade[] mins = new Grade[Utils.Categories.Length];
            Grade[] maxs = new Grade[Utils.Categories.Length];
            for (int i = 0; i < Utils.Categories.Length; i++)
            {
                mins[i] = new Grade(scores[i].Min());
                maxs[i] = new Grade(scores[i].Max());
            }
            minCountry = new Country("", mins);
            maxCountry = new Country("", maxs);
        }
        public void Filter(Country minCountry, Country maxCountry)
        {
            List<string> names = new List<string>();
            Grade[] minGrades = minCountry.GetGrades();
            Grade[] maxGrades = maxCountry.GetGrades();
            foreach (KeyValuePair<string, Country> kv in countries)
            {
                Grade[] grades = kv.Value.GetGrades();
                for (int i = 0; i < Utils.Categories.Length; i++)
                {
                    if (minGrades[i].Score > grades[i].Score || grades[i].Score > maxGrades[i].Score)
                    {
                        names.Add(kv.Key);
                        break;
                    }
                }

            }
            Remove(names.ToArray());
        }
        public void GetCountry(DataRow row, out Country country)
        {
            string name = (string)row[Utils.CountryParam.Text];
            country = countries[name];
        }
        public void UpdateCountry(string name, Grade[] newGrades)
        {
            Country c = new Country(name, newGrades);
            countries[name] = c;
            for (int i = 0; i < newGrades.Length; i++)
            {
                paramTableName2Rows[name][Utils.Categories[i].Text] = newGrades[i].Score;
            }
            UpdateScoreTable();
        }
        public void Write(StreamWriter sw)
        {
            Utils.Serialize(sw, countries.Values.ToArray());
        }
        public Country[] Read(StreamReader sr)
        {
            return Utils.Deserialize(sr);
        }
        public void Clear()
        {
            countries.Clear();
            paramTableName2Rows.Clear();
            scoreTableName2Rows.Clear();
            ParamTable.Clear();
            ScoreTable.Clear();
        }
    }
}
