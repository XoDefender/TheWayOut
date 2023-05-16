using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SpinAction : BaseAction
{
    private float totalSpinAmount;

    public Sprite SpinPhoto;

    void Update()
    {
        if (!isActive) return;

        float spinAmount = 360f * Time.deltaTime;
        totalSpinAmount += spinAmount;
        transform.eulerAngles += new Vector3(0, spinAmount, 0);

        if (totalSpinAmount >= 360) ActionComplete();
    }

    public override void TakeAction(GridPosition gridPosition, Action OnActionComplete)
    {
        totalSpinAmount = 0;
        ActionStart(OnActionComplete);
    }

    public override List<GridPosition> GetValidActionGridPositions()
    {
        GridPosition unitGridPosition = unit.GridPosition;

        return new List<GridPosition>
        {
            unitGridPosition
        };
    }

    public override EnemyAIAction GetEnemyAIAction(GridPosition gridPosition)
    {
        return new EnemyAIAction
        {
            gridPosition = gridPosition,
            actionValue = 0,
        };
    }

    public override string GetActionName() { return "Spin"; }

    public override Sprite GetActionPhoto()
    {
        return SpinPhoto;
    }

    public override int GetActionPointsCost() { return 1; }
}
