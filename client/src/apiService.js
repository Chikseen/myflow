const apiService = {
  async post(adress, payload) {
    const request = await fetch(process.env.VUE_APP_API + `/${adress}`, {
      body: JSON.stringify(payload),
      method: "POST",
      mode: "cors",
      headers: {
        "Access-Control-Allow-Origin": "*",
        "Content-Type": "application/json",
      },
    });
    return await request.json();
  },
  get(adress) {
    return fetch(`${process.env.VUE_APP_API}/${adress}`, { mode: "cors" }).then((r) => r.json());
  },
  delete(adress) {
    return fetch(`${process.env.VUE_APP_API}/${adress}`, {
      method: "DELETE",
      mode: "cors",
      headers: {
        "Access-Control-Allow-Origin": "*",
        "Access-Control-Allow-Method": "DELETE",
      },
    });
  },
  put(adress, payload) {
    return fetch(`${process.env.VUE_APP_API}/${adress}`, {
      body: JSON.stringify(payload),
      method: "PUT",
      mode: "cors",
      headers: {
        "Access-Control-Allow-Origin": "*",
        "Content-Type": "application/json",
      },
    });
  },
};

export default apiService;
