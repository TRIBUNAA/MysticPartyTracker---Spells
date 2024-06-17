using CommunityToolkit.Mvvm.ComponentModel;
using MysticPartyTracker.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MysticPartyTracker.ViewModels
{
    public partial class CharacterViewModels : ObservableObject
    {
        public CharacterViewModels() { }

        [ObservableProperty]
        private string _name;

        [ObservableProperty]
        private string _classe;

        [ObservableProperty]
        private string _raca;

        [ObservableProperty]
        private int _level;

        private ObservableCollection<Character> _characters = new ObservableCollection<Character>();
         ObservableCollection<Character> Characters {
            get { return _characters; }
            set { _characters = value; }

        }

        public ICommand CreateCharacterCommand { get; }

        public void AddCharacter ()
        {
            _characters.Add(new Character (Name, Level, Classe, Raca));
        }

        
    }

}
