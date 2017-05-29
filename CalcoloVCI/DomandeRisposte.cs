

namespace DomandeRisposte.Anagrafica
{
    public static class Ambito
    {
        public const int IT = 1;
        public const int Network = 2;
        public const int BusinessICTMercato = 3;
        public const int BusinessSistemiASupporto = 4;
        public const int Altro = 5;
    }

    public static class Risposta
    {
        public const int No = 0;
        public const int Si = 1;
        public const int NonDisponibile = 2;
    }

}

namespace DomandeRisposte.Compliance
{
    public static class Perimetro 
    {
        public const int Magistratura = 0;
        public const int DatiIntercettazzione = 1;
        public const int OLO = 2;
        public const int SOX = 3;
        public const int Cessati = 4;
        public const int DipartimentiCessati = 5;
        public const int CustomerProfiling = 6;
        public const int CustomerProfilingConsensato = 7;
        public const int DatiPseudonimi = 8;
        public const int ReatiInformatici231 = 9;
        public const int ReatiInformatici231AMedioRischioInerente = 10;
        public const int Resilienza = 11;
        public const int InformazioniPrivilegiate = 12;
        public const int DipartimentaleGarante3 = 13;
        public const int PostaElettronica = 14;
        public const int NavigazioneInternet = 15;
        public const int DisasterRecovery = 16;
        public const int PCIDSS = 17;
        public const int PV = 18;
        public const int PortaliWeb = 19;
        public const int PortaliWebAdAccessoSelettivo = 20;
        public const int PortaliWebConContenutiUtentiContraenti = 21;
        public const int CookieAnalyticsTerzeParti = 22;
        public const int CookieProfilazionePrimaParte = 23;
        public const int CookieProfilazioneTerzeParti = 24;
        public const int ICTMercato = 25;
        public const int ICTMercato231ReatiInformatici = 26;
        public const int ICTMercato231AMedioRischioInerente = 27;
        public const int ICTMercatoSanitario = 28;
        public const int ICTMercatoFSEDossierSanitario = 29;
        public const int ICTMercatoCartePagamento = 30;
        public const int ICTMercatoRegolamentoEnergia = 31;
        public const int ICTMercatoAmbitoBancarioCircolare263 = 32;
        public const int ICTMercatoScambioDatiPersonaliTraPA = 33;
        public const int ICTMercatoPortaliWeb = 34;
    }
    public static class Risposta
    {
        public const int No = 0;
        public const int Si = 1;
    }
}

namespace DomandeRisposte.Impatti
{

    public static class Riservatezza
    {
        public const int Basso = 1;
        public const int Medio = 2;
        public const int Alto = 3;
    }

    public static class Integrita
    {
        public const int Basso = 1;
        public const int Medio = 2;
        public const int Alto = 3;
    }

    public static class Disponibilita
    {
        public const int MaggioreDiUnaSettimana = 0;
        public const int MinoreDiUnaSettimana = 1;
        public const int MinoreDiUnGiorno = 2;
        public const int MinoreDiUnOra = 3;
        public const int MassimaPriorita = 4;
    }

}


namespace DomandeRisposte.Processi
{

    public static class Domanda
    {
        public const int CustomerRelationshipManagement = 0;
        public const int MarketingAndOfferManagement = 1;
        public const int SupplierAndPartnerRelationshipManagement = 2;
        public const int ServiceDevelopmentAndManagement = 3;
        public const int ResourceManagementAndOperations = 4;
        public const int ServiceManagementAndOperations = 5;
        public const int ResourceDevelopmentAndManagement = 6;
        public const int SupplyChainDevelopmentAndManagement = 7;
        public const int EnterpriseRiskManagement = 8;
        public const int StrategicEnterprisePlanning = 9;
        public const int EnterpriseEffectivenessManagement = 10;
        public const int FinancialAndAssetManagement = 11;
        public const int StakeholderAndExternalRelationsManagement = 12;
        public const int KnowledgeAndResearchManagement = 13;
        public const int HumanResourcesManagement = 14;
    }

    public static class Risposta
    {
        public const int Nessuno = 0;
        public const int Marginale = 1;
        public const int PocoInfluente = 2;
        public const int Influente = 3;
        public const int Rilevante = 4;
        public const int Determinante = 5;
    }

}

namespace DomandeRisposte.TipoDati
{
    public static class Perimetro
    {
        public const int NO196 = 0;
        public const int DatiPersonali = 1;
        public const int DatiSensibili = 2;
        public const int DatiGiudiziari = 3;
        public const int DatiTraffico = 4;
        public const int DatiLocalizzazione = 5;
    }
    public static class Risposta
    {
        public const int No = 0;
        public const int Si = 1;
    }
}

