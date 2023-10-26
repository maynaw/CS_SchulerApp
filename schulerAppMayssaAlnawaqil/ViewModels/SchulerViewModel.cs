using schulerAppMayssaAlnawaqil.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schulerAppMayssaAlnawaqil.ViewModels
{
    internal class SchulerViewModel : INotifyPropertyChanged
    {
        public SchulerViewModel()
        {
            Schueler = new ObservableCollection<Schuler>();

        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
        public ObservableCollection<Schuler> Schueler { get; set; }

        private Schuler _AusgewaehltesSchuler;

        public Schuler AusgewaehltesSchuler
        {
            get { return _AusgewaehltesSchuler; }
            set
            {
                _AusgewaehltesSchuler = value;
                RaisePropertyChanged("AusgewaehltesSchuler");
            }
        }

        public Schuler NeuesSchuler { get; set; }

        private string _StatusAnzeige;

        public string Statusanzeige
        {
            get
            {
                if (Schueler.Count == 0)
                {
                    return "Es wurden keine Schueler gefunden";
                }

                return $"Es gibt {Schueler.Count} Schueler";
            }

        }

        internal void DeleteSchuler()
        {
            try
            {
                Schuler sDelete = _ctx.Schueler.Find(AusgewaehltesSchuler.SchulerId);
                if (sDelete != null)
                    _ctx.Schueler.Remove(sDelete);
                _ctx.SaveChanges();
                //zur ObservableCollection hinzufügen
                Schueler.Remove(AusgewaehltesSchuler);
                RaisePropertyChanged("Statusanzeige");
            }
            catch { }
        }

        public string SuchText { get; set; }
        internal void FilterSchueler()
        {
            Schueler = new ObservableCollection<Schuler>();
            foreach (Schuler schuler in
                _ctx.Schueler.Where(s => s.Firstname.Contains(SuchText)))
            {
                Schueler.Add(schuler);
            }
            RaisePropertyChanged("Schueler");
            RaisePropertyChanged("Statusanzeige");
        }

        SchulerDBContext _ctx = new SchulerDBContext();

        public void FillSchuelerFromDB()
        {
            Schueler = new ObservableCollection<Schuler>();
            foreach (Schuler schuler in _ctx.Schueler)
            {
                Schueler.Add(schuler);
            }
            RaisePropertyChanged("Statusanzeige");
        }
        public void AddSchuler()
        {
            //Clone -- Tiefe Kopie


            var schulerNeu = new Schuler()
            {
                Firstname = NeuesSchuler.Firstname,
                Lastname = NeuesSchuler.Lastname,
                ClassNo = NeuesSchuler.ClassNo,
            };

            //Zur DB hinzufügen
            _ctx.Schueler.Add(NeuesSchuler);
            _ctx.SaveChanges();
            //zur ObservableCollection hinzufügen
            Schueler.Add(schulerNeu);
            RaisePropertyChanged("Statusanzeige");
        }

    }
}
