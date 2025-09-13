int choice;                                 

do {
    ShowMenu();
    choice = GetMenuChoice();  // Simulated input method
    ExecuteMenuChoice(choice);
}
while (choice != 3); // 3 = Exit