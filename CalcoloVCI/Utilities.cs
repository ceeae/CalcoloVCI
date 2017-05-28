namespace Anagrafica
{
    public enum Risposta : int
    {
        No = 0, Si = 1, NonDisponibile = 2
    }

    public enum Ambito : int
    {
        IT = 1,
        Network = 2,
        BusinessICTMercato = 3,
        BusinessSistemiASupporto = 4,
        Altro = 5
    }

}

namespace TipoDati
{
    public enum Perimetro : int
    {
        NO196 = 0,
        DatiPersonali = 1,
        DatiSensibili = 2,
        DatiGiudiziari = 3,
        DatiTraffico = 4,
        DatiLocalizzazione = 5
    }
    public enum Risposta : int
    {
        No = 0, Si = 1
    }
}

namespace Compliance
{
    public enum Perimetro : int
    {
        Magistratura = 0,
        DatiIntercettazzione = 1,
        OLO = 2,
        SOX = 3,
        Cessati = 4,
        DipartimentiCessati = 5,
        CustomerProfiling = 6,
        CustomerProfilingConsensato = 7,
        DatiPseudonimi = 8,
        ReatiInformatici231 = 9,
        ReatiInformatici231AMedioRischioInerente = 10,
        Resilienza = 11,
        InformazioniPrivilegiate = 12,
        DipartimentaleGarante3 = 13,
        PostaElettronica = 14,
        NavigazioneInternet = 15,
        DisasterRecovery = 16,
        PCIDSS = 17,
        PV = 18,
        PortaliWeb = 19,
        PortaliWebAdAccessoSelettivo = 20,
        PortaliWebConContenutiUtentiContraenti = 21,
        CookieAnalyticsTerzeParti = 22,
        CookieProfilazionePrimaParte = 23,
        CookieProfilazioneTerzeParti = 24,
        ICTMercato = 25,
        ICTMercato231ReatiInformatici = 26,
        ICTMercato231AMedioRischioInerente = 27,
        ICTMercatoSanitario = 28,
        ICTMercatoFSEDossierSanitario = 29,
        ICTMercatoCartePagamento = 30,
        ICTMercatoRegolamentoEnergia = 31,
        ICTMercatoAmbitoBancarioCircolare263 = 32,
        ICTMercatoScambioDatiPersonaliTraPA = 33,
        ICTMercatoPortaliWeb = 34
    }
    public enum Risposta : int
    {
        No = 0, Si = 1
    }
}

namespace Impatti
{

    public enum Riservatezza : int
    {
        Basso = 1, Medio = 2, Alto = 3
    }

    public enum Integrita : int
    {
        Basso = 1, Medio = 2, Alto = 3
    }

    public enum Disponibilita : int
    {
        MaggioreDiUnaSettimana = 0,
        MinoreDiUnaSettimana = 1,
        MinoreDiUnGiorno = 2,
        MinoreDiUnOra = 3,
        MassimaPriorita = 4
    }

}

namespace Processi
{

    public enum Domanda : int
    {
        CustomerRelationshipManagement = 0,
        MarketingAndOfferManagement = 1,
        SupplierAndPartnerRelationshipManagement = 2,
        ServiceDevelopmentAndManagement = 3,
        ResourceManagementAndOperations = 4,
        ServiceManagementAndOperations = 5,
        ResourceDevelopmentAndManagement = 6,
        SupplyChainDevelopmentAndManagement = 7,
        EnterpriseRiskManagement = 8,
        StrategicEnterprisePlanning = 9,
        EnterpriseEffectivenessManagement = 10,
        FinancialAndAssetManagement = 11,
        StakeholderAndExternalRelationsManagement = 12,
        KnowledgeAndResearchManagement = 13,
        HumanResourcesManagement = 14
    }

    public enum Risposta : int
    {
        Nessuno = 0,
        Marginale = 1,
        PocoInfluente = 2,
        Influente = 3,
        Rilevante = 4,
        Determinante = 5
    }

}

