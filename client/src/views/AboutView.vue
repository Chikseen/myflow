<template>
  <div class="about">
    <h1>This is an about page</h1>
    <button @click="login">Login</button>
  </div>
</template>

<script>
import api from "@/apiService";

export default {
  methods: {
    login() {
      api.get("Auth/Login");
    },
  },
};
</script>
