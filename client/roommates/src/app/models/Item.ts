export class Item {
    id: number;
    name: string;

    constructor(name: string, id?: number) {
        this.id = id ?? 0;
        this.name = name;
    }
}