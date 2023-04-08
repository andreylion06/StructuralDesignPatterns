using FacadePattern.MenuLibrary;

BigMacMenu bigMacMenu = new BigMacMenu();

bigMacMenu.AddBigMac();
bigMacMenu.AddFrenchFries();
bigMacMenu.AddCocaCola();

decimal totalPrice = bigMacMenu.GetTotalPrice();