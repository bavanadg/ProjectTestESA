using ESA.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ESA.ViewModel
{

    public class LacrimalViewModel
    {
        public ObservableCollection<LacrimalModel> LacrimalList
        {
            get;
            set;
        }

        public LacrimalViewModel()
        {
            LoadLacrimal();
        }

        public void LoadLacrimal()
        {
            // lacrimalList will be set up to update from a database. This is an example.
            ObservableCollection<LacrimalModel> lacrimalList = new ObservableCollection<LacrimalModel>();

            LacrimalModel lacrimal1 = new LacrimalModel
            {
                Name = "Congenital lacrimal sinus (fistula/accessory punctum) excision",
                Details = "This narrated video demonstrates the excision of an " +
                "accessory lacrimal sinus or fistula and the insertion of a mini " +
                "Monoka stent to protect the normal canaliculus. It discusses the " +
                "different surgical options for this rare condition."

            };
            LacrimalModel lacrimal2 = new LacrimalModel
            {
                Name = "O’Donoghue stents for internal ostium fibrosis DCR failure",
                Details = "This narrated video demonstrates the endoscopic insertion of " +
                "O’Donoghue nasolacrimal stents into a patient whose DCR has failed because " +
                "of internal ostium fibrosis."
            };
            LacrimalModel lacrimal3 = new LacrimalModel
            {
                Name = "Flap Formation in Endoscopic DCR",
                Details = "This narrated video demonstrates the formation of lacrimal sac " +
                "and nasal mucosal flaps in endo DCR and reviews the different instruments " +
                "that can be used for these steps of endo DCR and the way that the flaps " +
                "should sit after they have been formed and opened out."
            };

            lacrimalList.Add(lacrimal1);
            lacrimalList.Add(lacrimal2);
            lacrimalList.Add(lacrimal3);

            LacrimalList = lacrimalList;

        }
    }
}
