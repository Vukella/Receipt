using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Communication
{
    public enum Operation
    {
        Login,
        CreateIngredient,
        GetAllIngredientsSearch,
        GetAllIngredientsByName,
        GetAllIngredientsById,
        FindIngredient,
        CreateMachine,
        GetAllMachinesSearch,
        GetAllMachinesByName,
        GetAllMachinesById,
        DeleteIngredient,
        CreateReceipt,
        GetAllReceiptsSearch,
        GetAllReceiptsByName,
        GetAllReceiptsById,
        FindReceipt,
        UpdateReceipt,
        DeleteEvidence,
        CreateEvidence,
        GetAllEvidenceSearch,
        GetAllEvidenceByName,
        GetAllEvidenceById,
        FindEvidence,
        SearchIngredients,
        UpdateIngredient,
        CreateReceiptStep,
        GetAllReceiptStepsSearch,
        DeleteReceiptStep,
        UpdateReceiptStep,
        GetAllSteps
    }
}
