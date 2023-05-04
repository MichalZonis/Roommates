import { Injectable } from '@angular/core';
import { Item } from '../models/Item';
import { HttpService } from './http.service';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ItemsService {

  private _items = new BehaviorSubject<Item>(new Item(""));
  items = this._items.asObservable();

  constructor(private http: HttpService) { }

  addItem(newItem: Item) {
    this.http.post(`Groceries/addItem`, newItem).subscribe((res: any) => {
      debugger
      this._items.next(newItem);
    })
  }
}
