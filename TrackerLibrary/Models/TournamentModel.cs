﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.Models
{
    public  class TournamentModel
    {

        public string TournamentName { get; set; }

        public decimal EntryFee { get; set; }

        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();

        public List<TournamentType> Types { get; set; } = new List<TournamentType>();
    }

}
