class Ordenação{
    public static void MergeSort(double[] arr, int left, int right) {
    if (left < right) {
        int middle = (left + right) / 2;
        MergeSort(arr, left, middle);
        MergeSort(arr, middle + 1, right);
        Merge(arr, left, middle, right);
    }
}

public static void Merge(double[] arr, int left, int middle, int right) {
    int n1 = middle - left + 1;
    int n2 = right - middle;

    double[] L = new double[n1];
    double[] R = new double[n2];

    for (int i = 0; i < n1; i++) {
        L[i] = arr[left + i];
    }

    for (int j = 0; j < n2; j++) {
        R[j] = arr[middle + 1 + j];
    }

    int k = left;
    int l = 0;
    int r = 0;

    while (l < n1 && r < n2) {
        if (L[l] <= R[r]) {
            arr[k] = L[l];
            l++;
        }
        else {
            arr[k] = R[r];
            r++;
        }
        k++;
    }

    while (l < n1) {
        arr[k] = L[l];
        l++;
        k++;
    }

    while (r < n2) {
        arr[k] = R[r];
        r++;
        k++;
    }
}
}