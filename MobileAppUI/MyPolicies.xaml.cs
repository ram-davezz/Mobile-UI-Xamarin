using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.CommunityToolkit;

namespace MobileAppUI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {

        public Page1()
        {
            InitializeComponent();

        }

        private void MyPolicyExpander_Tapped(object sender, EventArgs e)
        {
            if (MyPolicyExpander.IsExpanded == true)
            {
                MyPoliciesImg.Source = ImageSource.FromFile("uparrow.png");

                PolicyChangesExpander.IsExpanded = false;
                PolicyChangesImg.Source = ImageSource.FromFile("downarrow.png");

                LapsedPolicyExpander.IsExpanded = false;
                LapsedPolicyImg.Source = ImageSource.FromFile("downarrow.png");

                MobilePayExpander.IsExpanded = false;
                PaymentImg.Source = ImageSource.FromFile("downarrow.png");
            }
            else if (MyPolicyExpander.IsExpanded == false)
            {   
                MyPoliciesImg.Source = ImageSource.FromFile("downarrow.png");
            }
        }

        private void MobilePayExpander_Tapped(object sender, EventArgs e)
        {
            if (MobilePayExpander.IsExpanded == true)
            {
                PaymentImg.Source = ImageSource.FromFile("uparrow.png");

                MyPolicyExpander.IsExpanded = false;
                MyPoliciesImg.Source = ImageSource.FromFile("downarrow.png");

                LapsedPolicyExpander.IsExpanded = false;
                LapsedPolicyImg.Source = ImageSource.FromFile("downarrow.png");

                PolicyChangesExpander.IsExpanded = false;
                PolicyChangesImg.Source = ImageSource.FromFile("downarrow.png");
            }
            else if (MyPolicyExpander.IsExpanded == false)
            {
                PaymentImg.Source = ImageSource.FromFile("downarrow.png");
            }
        }

        private void LapsedPolicyExpander_Tapped(object sender, EventArgs e)
        {
            if (LapsedPolicyExpander.IsExpanded == true)
            {
                LapsedPolicyImg.Source = ImageSource.FromFile("uparrow.png");

                MyPolicyExpander.IsExpanded = false;
                MyPoliciesImg.Source = ImageSource.FromFile("downarrow.png");

                PolicyChangesExpander.IsExpanded = false;
                PolicyChangesImg.Source = ImageSource.FromFile("downarrow.png");

                MobilePayExpander.IsExpanded = false;
                PaymentImg.Source = ImageSource.FromFile("downarrow.png");
            }
            else if (MyPolicyExpander.IsExpanded == false)
            {
                LapsedPolicyImg.Source = ImageSource.FromFile("downarrow.png");
            }
        }

        private void PolicyChangesExpander_Tapped(object sender, EventArgs e)
        {
            if (PolicyChangesExpander.IsExpanded == true)
            {
                PolicyChangesImg.Source = ImageSource.FromFile("uparrow.png");

                MyPolicyExpander.IsExpanded = false;
                MyPoliciesImg.Source = ImageSource.FromFile("downarrow.png");

                LapsedPolicyExpander.IsExpanded = false;
                LapsedPolicyImg.Source = ImageSource.FromFile("downarrow.png");

                MobilePayExpander.IsExpanded = false;
                PaymentImg.Source = ImageSource.FromFile("downarrow.png");
            }
            else if (MyPolicyExpander.IsExpanded == false)
            {
                PolicyChangesImg.Source = ImageSource.FromFile("downarrow.png");
            }
        }

        private void customBackButtton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }

}