
int _detailInit = 0;
void DetailLayoutDesign_OnBeforeInitialization()
{
    _detailInit++;
    LabelResult.Text = "DetailLayoutDesign_OnBeforeInitialization";
}

void DetailLayoutDesign_OnAfterInitialization()
{
    _detailInit++;
    LabelResult.Text = "DetailLayoutDesign_OnAfterInitialization" + _detailInit;
}

int _listInit = 0;
void ListLayoutDesign_OnBeforeInitialization()
{
    _listInit++;
    LabelResult.Text = "ListLayoutDesign_OnBeforeInitialization";
}
void ListLayoutDesign_OnAfterInitialization()
{
    _listInit++;
    LabelResult.Text = "ListLayoutDesign_OnAfterInitialization" + _listInit;
}
void SearchLayoutDesign_OnSearchInitialization()
{
    Boolean.SearchValue = true;
}