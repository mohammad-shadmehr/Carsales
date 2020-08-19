import { Component, Inject } from '@angular/core';
import { MatDialog, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { BoatComponent, IBoatDto } from './boat.component';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'add-update-boat-dialog',
  templateUrl: 'add-update-boat-dialog.component.html',
})
export class AddUpdateBoatDialog {
  baseUrl = 'https://localhost:44391/api/Boat/';

  constructor(
    public dialogRef: MatDialogRef<BoatComponent>,
    @Inject(MAT_DIALOG_DATA) public data: IBoatDto, public http: HttpClient) { }

  onNoClick(): void {
    this.dialogRef.close();
  }

  save() {
    this.http.post(`${this.baseUrl}AddOrUpdate`, this.data).subscribe(() => {
      this.dialogRef.close();
    }, error => {
        alert('An error occurred and no data was saved!');
    });
  }
}
