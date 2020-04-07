using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    public class ButterflyModel
    {
    #region Properties
   
    public BoxCollider2D BoxCollider2D { get; }
    public Transform ButterflyTransform { get; }
    public ButterflyData ButterflyData;
    public ButterflyStruct ButterflyStruct;

        #endregion


        #region ClassLifeCycle
    
   public ButterflyModel(GameObject prefab, ButterflyData Butterflydata)
        {
            
            ButterflyData = Butterflydata;
            ButterflyStruct = Butterflydata.ButterflyStruct;
            ButterflyTransform = prefab.transform;
        BoxCollider2D = prefab.gameObject.GetComponent<BoxCollider2D>();
    }
    #endregion


    #region Metods

    public void Initilize()
        {
        // ButterflyData.ChangeButterflyCollider(ButterflyCollider, ButterflyStruct.ButterflyRadius);
            ButterflyData.Move(ButterflyTransform, ButterflyStruct.Target, ButterflyStruct.MoveSpeed);
        }

        #endregion






    
}