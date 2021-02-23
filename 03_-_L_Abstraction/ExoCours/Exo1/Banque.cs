using System.Collections.Generic; 

namespace Exo1
{
    public class Banque
    {
        List<Account> _allAccounts;

        private int _numberUsed = 0;
        private int _numberCarte = 0;

        public Banque()
        {
            _allAccounts = new List<Account>();
        }

        public int Search(int numberAccount)
        {
            for(int i = 0; i < _allAccounts.Count; i++)
            {
                if(_allAccounts[i].Number == numberAccount)
                {
                    return i;
                }
            }
            return -1;
        }

        private int GetNewNumberAccount()
        {
            int newNumber = _numberUsed;
            _numberUsed++;
            return newNumber;
        }
        private int GetNewNumberCarte()
        {
            int newNumber = _numberCarte;
            _numberCarte++;
            return newNumber;
        }

        public void AddAccountCarnet(string nameOwner, float solde)
        {
            CompteSurCarnet newAccountCarnet = new CompteSurCarnet(GetNewNumberAccount(), nameOwner, solde, 0);
            _allAccounts.Add(newAccountCarnet);
        }

        public void AddAccountCheque(string nameOwner, float solde, int dateFinValidite)
        {
            CompteSurCheque newAccountCheque = new CompteSurCheque(GetNewNumberAccount(), nameOwner, solde, 0, GetNewNumberCarte(), dateFinValidite);
            _allAccounts.Add(newAccountCheque);
        }        

        public void RemoveAccount(int numberAccount)
        {
            for(int i = 0; i < _allAccounts.Count; i++)
            {
                if(_allAccounts[i].Number == numberAccount)
                {
                    _allAccounts.Remove(_allAccounts[i]);
                    return;
                }
            }
        }

        public Account GetAccount(int numberAccount)
        {
            foreach(Account account in _allAccounts)
            {                
                if(account.Number == numberAccount)
                {
                    return account;
                }
            }
            return null;
        }
    }
}