using IndianStateCensusAnalyser.POCO;
using System;

namespace IndianStateCensusAnalyser.POCO
{
    public class CensusDTO
    {
        public int serialNumber;
        public string stateName;
        public string state;
        public int tin;
        public string stateCode;
        public long population;
        public long area;
        public long density;
        public long housingUnits;
        public double totalArea;
        public double waterArea;
        public double landArea;
        public double populationDensity;
        public double housingDensity;

        public CensusDTO(StateCodeDAO stateCodeDAO)
        {
            this.serialNumber = stateCodeDAO.serialNumber;
            this.stateName = stateCodeDAO.stateName;
            this.tin = stateCodeDAO.tin;
            this.stateCode = stateCodeDAO.stateCode;
        }

        public CensusDTO(CensusDataDAO censusDataDAO)
        {
            this.state = censusDataDAO.state;
            this.population = censusDataDAO.population;
            this.area = censusDataDAO.area;
            this.density = censusDataDAO.density;
        }

        //public CensusDTO(USCensusDAO uSCensusDAO)
        //{
        //    this.stateCode = uSCensusDAO.stateId;
        //    this.stateName = uSCensusDAO.stateName;
        //    this.population = uSCensusDAO.population;
        //    this.housingUnits = uSCensusDAO.houseUnits;]
        //    this.totalArea = uSCensusDAO.totalArea;
        //    this.waterArea = uSCensusDAO.waterArea;
        //    this.landArea = uSCensusDAO.landArea;
        //    this.populationDensity = uSCensusDAO.populationDensity;
        //    this.housingDensity = uSCensusDAO.housingDensity;
        //}
    }
}
