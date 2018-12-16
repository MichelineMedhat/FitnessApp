﻿using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace FitnessApp.AdminMainWindowPages
{
    /// <summary>
    /// Interaction logic for AdminSettingsPage.xaml
    /// </summary>
    public partial class AdminSettingsPage : Page
    {
        public AdminSettingsPage()
        {
            InitializeComponent();
            AdminMainWindow.AdminSettingsPageObject = this;

            // Initialize Profile Expander to be expanded
            AccountExpander.IsExpanded = true;

            // Initialize DataContext with signedInAdmin Model
            //DataContext = AdminMainWindow.signedInUser;
        }

        private void Expander_Expanded(object sender, System.Windows.RoutedEventArgs e)
        {
            // Remove Expanded Event Handler from all Expanders
            // to prevent calling Expander_Expanded Event Handler 
            // recursively.
            AccountExpander.Expanded  -= Expander_Expanded;
            SecurityExpander.Expanded -= Expander_Expanded;
            HelpExpander.Expanded     -= Expander_Expanded;

            // Close all Expanders.
            AccountExpander.IsExpanded  = false;
            SecurityExpander.IsExpanded = false;
            HelpExpander.IsExpanded     = false;

            // Re-add Expanded Event Handler to all Expanders.
            AccountExpander.Expanded  += Expander_Expanded;
            SecurityExpander.Expanded += Expander_Expanded;
            HelpExpander.Expanded     += Expander_Expanded;


            // Get Current Expander object from sender.
            Expander currentExpander = sender as Expander;

            // Remove Expanded Event Handler from Current Expander.
            currentExpander.Expanded -= Expander_Expanded;

            // Open current Expander only.
            currentExpander.IsExpanded = true;

            // Re-add Expanded Event Handler to Current Expander.
            currentExpander.Expanded += Expander_Expanded;

        }


        private void UpdateAccountButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            // Update Account Code Here...
        }

        private void UpdatePasswordButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            // Update Password Code Here...
        }
    }
}