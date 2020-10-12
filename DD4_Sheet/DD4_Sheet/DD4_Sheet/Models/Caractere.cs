﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace DD4_Sheet.Models
{
    public class Caractere : INotifyPropertyChanged
    {
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

        public string Classe
        {
            get
            {
                return _classe;
            }
            set
            {
                if (_classe != value)
                {
                    _classe = value;
                    OnPropertyChanged("Classe");
                }
            }
        }

        public string Race
        {
            get
            {
                return _race;
            }
            set
            {
                if (_race != value)
                {
                    _race = value;
                    OnPropertyChanged("Race");
                }
            }
        }

        public string ParangonPath
        {
            get
            {
                return _paranP;
            }
            set
            {
                if (_paranP != value)
                {
                    _paranP = value;
                    OnPropertyChanged("ParangonPath");
                }
            }
        }

        public string EpicDestiny
        {
            get
            {
                return _epicD;
            }
            set
            {
                if (_epicD != value)
                {
                    _epicD = value;
                    OnPropertyChanged("EpicDestiny");
                }
            }
        }

        public string Languages
        {
            get
            {
                return _lang;
            }
            set
            {
                if (_lang != value)
                {
                    _lang = value;
                    OnPropertyChanged("Languages");
                }
            }
        }

        public string Description
        {
            get
            {
                return _descr;
            }
            set
            {
                if (_descr != value)
                {
                    _descr = value;
                    OnPropertyChanged("Description");
                }
            }
        }

        public string Background
        {
            get
            {
                return _bg;
            }
            set
            {
                if (_bg != value)
                {
                    _bg = value;
                    OnPropertyChanged("Background");
                }
            }
        }

        public string ParangonBG
        {
            get
            {
                return _paranBG;
            }
            set
            {
                if (_paranBG != value)
                {
                    _paranBG = value;
                    OnPropertyChanged("ParangonBG");
                }
            }
        }

        public string EpicDestinyBG
        {
            get
            {
                return _epicBG;
            }
            set
            {
                if (_epicBG != value)
                {
                    _epicBG = value;
                    OnPropertyChanged("EpicDestinyBG");
                }
            }
        }

        public int Xp
        {
            get
            {
                return _xp;
            }
            set
            {
                if (_xp != value)
                {
                    _xp = value;
                    OnPropertyChanged("Xp");
                    OnPropertyChanged("Lvl");
                }
            }
        }

        public int Lvl
        {
            get
            {
                int rtn = 0;

                foreach (int val in _tabLvl)
                {
                    if (_xp < val) { break; }

                    rtn++;
                }

                return rtn;
            }
        }

        public List<Feature> Features { get; set; }
        public List<string> Featureees { get; set; }



        /*public Feature Strenght { get { return _for; } set { _for = value; } }
        public Feature Constitution { get { return _con; } set { _con = value; } }
        public Feature Dexterity { get { return _dex; } set { _dex = value; } }
        public Feature Intelligence { get { return _int; } set { _int = value; } }
        public Feature Wisdom { get { return _sag; } set { _sag = value; } }
        public Feature Charisma { get { return _cha; } set { _cha = value; } }

        private Feature _for, _con, _dex, _int, _sag, _cha;
        */

        //private Feature _for;
        private string _name, _classe, _race, _paranP, _epicD, _lang, _descr, _bg, _paranBG, _epicBG;
        private int _xp;
        private List<int> _tabLvl;
        //private Dictionary<string, Feature> _features;

        public event PropertyChangedEventHandler PropertyChanged;

        public Caractere ()
        {
            Xp = 0;

            _tabLvl = new List<int>(30);
            _tabLvl.Add(0);
            _tabLvl.Add(1000);
            _tabLvl.Add(2250);
            _tabLvl.Add(3750);
            _tabLvl.Add(5500);
            _tabLvl.Add(7500);
            _tabLvl.Add(10000);
            _tabLvl.Add(13000);
            _tabLvl.Add(16500);
            _tabLvl.Add(20500);
            _tabLvl.Add(26000);
            _tabLvl.Add(32000);
            _tabLvl.Add(39000);
            _tabLvl.Add(47000);
            _tabLvl.Add(57000);
            _tabLvl.Add(69000);
            _tabLvl.Add(83000);
            _tabLvl.Add(99000);
            _tabLvl.Add(119000);
            _tabLvl.Add(143000);
            _tabLvl.Add(175000);
            _tabLvl.Add(210000);
            _tabLvl.Add(255000);
            _tabLvl.Add(310000);
            _tabLvl.Add(375000);
            _tabLvl.Add(450000);
            _tabLvl.Add(550000);
            _tabLvl.Add(675000);
            _tabLvl.Add(825000);
            _tabLvl.Add(1000000);

            Features = new List<Feature>(6);
            Features.Add(new Feature("Force"));
            Features.Add(new Feature("Constitution"));
            Features.Add(new Feature("Dexterité"));
            Features.Add(new Feature("Intelligence"));
            Features.Add(new Feature("Sagesse"));
            Features.Add(new Feature("Charisme"));

            Featureees = new List<string>();
            Featureees.Add("Force");
            Featureees.Add("Constitution");
            Featureees.Add("Dexterité");
            Featureees.Add("Intelligence");
            Featureees.Add("Sagesse");
            Featureees.Add("Charisme");
            Featureees.Add("Force");
            Featureees.Add("Constitution");
            Featureees.Add("Dexterité");
            Featureees.Add("Intelligence");
            Featureees.Add("Sagesse");
            Featureees.Add("Charisme");
            Featureees.Add("Force");
            Featureees.Add("Constitution");
            Featureees.Add("Dexterité");
            Featureees.Add("Intelligence");
            Featureees.Add("Sagesse");
            Featureees.Add("Charisme");


            /*_for = new Feature("Force");
            _con = new Feature("Constitution");
            _dex = new Feature("Dexterité");
            _int = new Feature("Intelligence");
            _sag = new Feature("Sagesse");
            _cha = new Feature("Charisme");
            */
        }

        public virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string ToXML ()
        {
            using (var writer = new StringWriter())
            {
                CaractereXML cXml = new CaractereXML(this);

                var serializer = new System.Xml.Serialization.XmlSerializer(cXml.GetType());
                serializer.Serialize(writer, cXml);
                return writer.ToString();
            }
        }

        public static Caractere LoadXML (string xml)
        {
            using (var reader = new StringReader(xml))
            {
                var serializer = new System.Xml.Serialization.XmlSerializer(typeof(CaractereXML));
                CaractereXML cXml = serializer.Deserialize(reader) as CaractereXML;

                return cXml.ToCaractere();
            }
        }

        /*
        public void save ()
        {
            IFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            string docPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
            Stream stream = new FileStream(docPath, FileMode.Create, FileAccess.Write);

            Debug.WriteLine(docPath);

            formatter.Serialize(stream, this);
            stream.Close();
        }
        */
    }

    public class CaractereXML
    {
        private string _name, _classe, _race, _paranP, _epicD, _lang, _descr, _bg, _paranBG, _epicBG;
        private int _xp;
        private List<string> _listFeatures;

        public CaractereXML (Caractere c)
        {
            _name = c.Name;
            _classe = c.Classe;
            _race = c.Race;
            _paranP = c.ParangonPath;
            _epicD = c.EpicDestiny;
            _paranBG = c.ParangonBG;
            _epicBG = c.EpicDestinyBG;
            _lang = c.Languages;
            _descr = c.Description;
            _bg = c.Background;
            _xp = c.Xp;

            _listFeatures = new List<string>(c.Features.Count);
            foreach (Feature f in c.Features)
            {
                _listFeatures.Add(f.ToXML());
            }
        }

        public Caractere ToCaractere ()
        {
            Caractere rtn = new Caractere();

            rtn.Name = _name;
            rtn.Classe = _classe;
            rtn.Race = _race;
            rtn.ParangonPath = _paranP;
            rtn.EpicDestiny = _epicD;
            rtn.ParangonBG = _paranBG;
            rtn.EpicDestinyBG = _epicBG;
            rtn.Languages = _lang;
            rtn.Description = _descr;
            rtn.Background = _bg;
            rtn.Xp = _xp;

            rtn.Features = new List<Feature>(_listFeatures.Count);
            foreach (string s in _listFeatures)
            {
                rtn.Features.Add(Feature.LoadXML(s));
            }

            return rtn;
        }

    }
}
