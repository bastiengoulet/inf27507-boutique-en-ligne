﻿namespace INF27507_Boutique_En_Ligne.Services
{
    public interface IAuthentificationAdapter
    {
        void SetDefaultUser(ISession session);
        bool IsAuthenticated(ISession session);
        bool IsAuthenticatedAsClient(ISession session);
    }
}