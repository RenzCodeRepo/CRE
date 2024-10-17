﻿using CRE.Models;

namespace CRE.ViewModels
{
    public class InitialReviewViewModel
    {
        public AppUser AppUser { get; set; }
        public Secretariat Secretariat { get; set; }
        public Chief Chief { get; set; }
        public NonFundedResearchInfo NonFundedResearchInfo { get; set; }
        public CoProponent CoProponent { get; set; }
        public ReceiptInfo ReceiptInfo { get; set; }
        public Chairperson Chairperson { get; set; }
        public EthicsEvaluator EthicsEvaluator { get; set; }
        public EthicsApplication EthicsApplication { get; set; }
        public InitialReview InitialReview { get; set; }
        public IEnumerable<EthicsApplicationForms> EthicsApplicationForms { get; set; }
        public IEnumerable<EthicsApplicationLog> EthicsApplicationLog { get; set; } 
        

    }
}
